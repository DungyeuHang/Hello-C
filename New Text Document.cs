using Autodesk.AutoCAD.ApplicationServices;
using Autodesk.AutoCAD.EditorInput;
using Autodesk.AutoCAD.Runtime;
using Autodesk.AutoCAD.Geometry;
using Autodesk.AutoCAD.DatabaseServices;

namespace MyAutoCADPlugin
{
    public class MyCommands
    {
        // 🟢 Lệnh vẽ Line giữa 2 điểm
        [CommandMethod("VE_LINE")]
        public void VeLine()
        {
            Document doc = Application.DocumentManager.MdiActiveDocument;
            Editor ed = doc.Editor;

            PromptPointResult p1 = ed.GetPoint("\nChọn điểm đầu: ");
            if (p1.Status != PromptStatus.OK) return;

            PromptPointOptions ppo = new PromptPointOptions("\nChọn điểm cuối: ");
            ppo.BasePoint = p1.Value;
            ppo.UseBasePoint = true;
            PromptPointResult p2 = ed.GetPoint(ppo);
            if (p2.Status != PromptStatus.OK) return;

            Database db = doc.Database;
            using (Transaction trans = db.TransactionManager.StartTransaction())
            {
                BlockTable bt = trans.GetObject(db.BlockTableId, OpenMode.ForRead) as BlockTable;
                BlockTableRecord btr = trans.GetObject(db.CurrentSpaceId, OpenMode.ForWrite) as BlockTableRecord;

                Line line = new Line(p1.Value, p2.Value);
                btr.AppendEntity(line);
                trans.AddNewlyCreatedDBObject(line, true);
                trans.Commit();
            }

            ed.WriteMessage("\n✅ Đã vẽ xong Line!");
        }

        // 🔵 Lệnh vẽ Polyline nhiều điểm
        [CommandMethod("VE_PLINE")]
        public void VePolyline()
        {
            Document doc = Application.DocumentManager.MdiActiveDocument;
            Editor ed = doc.Editor;

            Database db = doc.Database;
            Point3dCollection diemList = new Point3dCollection();

            // Nhập điểm đầu tiên
            PromptPointResult pRes = ed.GetPoint("\nChọn điểm đầu tiên: ");
            if (pRes.Status != PromptStatus.OK) return;

            diemList.Add(pRes.Value);

            while (true)
            {
                PromptPointOptions ppo = new PromptPointOptions("\nChọn điểm tiếp theo hoặc ENTER để kết thúc: ");
                ppo.BasePoint = diemList[diemList.Count - 1];
                ppo.UseBasePoint = true;

                PromptPointResult pNext = ed.GetPoint(ppo);

                if (pNext.Status == PromptStatus.OK)
                {
                    diemList.Add(pNext.Value);
                }
                else
                {
                    break;
                }
            }

            if (diemList.Count < 2)
            {
                ed.WriteMessage("\n⚠ Cần ít nhất 2 điểm để tạo polyline.");
                return;
            }

            using (Transaction trans = db.TransactionManager.StartTransaction())
            {
                BlockTable bt = trans.GetObject(db.BlockTableId, OpenMode.ForRead) as BlockTable;
                BlockTableRecord btr = trans.GetObject(db.CurrentSpaceId, OpenMode.ForWrite) as BlockTableRecord;

                Polyline pl = new Polyline();
                for (int i = 0; i < diemList.Count; i++)
                {
                    Point2d pt2d = new Point2d(diemList[i].X, diemList[i].Y);
                    pl.AddVertexAt(i, pt2d, 0, 0, 0);
                }

                btr.AppendEntity(pl);
                trans.AddNewlyCreatedDBObject(pl, true);
                trans.Commit();
            }

            ed.WriteMessage($"\n✅ Đã vẽ polyline với {diemList.Count} điểm!");
        }
    }
}
