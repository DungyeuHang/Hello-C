using Autodesk.AutoCAD.Runtime;
using Autodesk.AutoCAD.ApplicationServices;
using Autodesk.AutoCAD.EditorInput;
using Autodesk.AutoCAD.DatabaseServices;
using Autodesk.AutoCAD.Geometry;
using System.Collections.Generic;
using System.Linq;

public class ChiaDimCommands
{
    [CommandMethod("CDD_CHIADIM")]
    public void ChiaDim()
    {
        Document doc = Application.DocumentManager.MdiActiveDocument;
        Editor ed = doc.Editor;
        Database db = doc.Database;

        // ================= SELECT DIM =================
        PromptEntityOptions peo = new PromptEntityOptions("\nChọn DIM cần chia: ");
        peo.SetRejectMessage("\nKhông phải DIM.");
        peo.AddAllowedClass(typeof(Dimension), true);

        PromptEntityResult per = ed.GetEntity(peo);
        if (per.Status != PromptStatus.OK) return;

        using (Transaction tr = db.TransactionManager.StartTransaction())
        {
            Dimension dim = tr.GetObject(per.ObjectId, OpenMode.ForWrite) as Dimension;
            if (dim == null) return;

            // ================= GET DIM POINTS =================
            Point3d pt1 = dim.XLine1Point;
            Point3d pt2 = dim.XLine2Point;
            Point3d ptDim = dim.DimLinePoint;

            // ================= PICK DIVISION POINTS =================
            List<Point3d> points = new List<Point3d> { pt1 };

            while (true)
            {
                PromptPointOptions ppo = new PromptPointOptions("\nChọn điểm chia (Enter để kết thúc): ");
                PromptPointResult ppr = ed.GetPoint(ppo);

                if (ppr.Status != PromptStatus.OK)
                    break;

                points.Add(new Point3d(ppr.Value.X, ppr.Value.Y, 0));
            }

            points.Add(pt2);

            if (points.Count < 3)
            {
                ed.WriteMessage("\nKhông đủ điểm chia.");
                return;
            }

            // ================= SORT POINTS =================
            points = points
                .OrderBy(p => p.DistanceTo(pt1))
                .ToList();

            // ================= DELETE OLD DIM =================
            dim.Erase();

            BlockTable bt = tr.GetObject(db.BlockTableId, OpenMode.ForRead) as BlockTable;
            BlockTableRecord btr =
                tr.GetObject(bt[BlockTableRecord.ModelSpace], OpenMode.ForWrite)
                as BlockTableRecord;

            // ================= CREATE NEW DIMS =================
            for (int index = 0; index < points.Count - 1; index++)
            {
                Point3d pA = points[index];
                Point3d pB = points[index + 1];

                bool isHorizontal =
                    System.Math.Abs(pA.X - pB.X) > System.Math.Abs(pA.Y - pB.Y);

                RotatedDimension newDim = new RotatedDimension
                {
                    XLine1Point = pA,
                    XLine2Point = pB,
                    DimLinePoint = ptDim,
                    Rotation = isHorizontal ? 0 : System.Math.PI / 2,
                    DimensionStyle = db.Dimstyle
                };

                btr.AppendEntity(newDim);
                tr.AddNewlyCreatedDBObject(newDim, true);
            }

            tr.Commit();
        }

        ed.WriteMessage("\nChia DIM xong – C# version chạy bền như trâu 🐂");
    }
}
