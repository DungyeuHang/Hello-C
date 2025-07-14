using Autodesk.AutoCAD.ApplicationServices;
using Autodesk.AutoCAD.DatabaseServices;
using Autodesk.AutoCAD.EditorInput;
using Autodesk.AutoCAD.Geometry;
using Autodesk.AutoCAD.Runtime;

namespace MyAutoCADPlugin
{
    public class DrawLineCommand
    {
        [CommandMethod("VeLine")]
        public void VeLine()
        {
            Document doc = Application.DocumentManager.MdiActiveDocument;
            Database db = doc.Database;
            Editor ed = doc.Editor;

            // Chọn 2 điểm
            PromptPointResult p1 = ed.GetPoint("\nChọn điểm đầu: ");
            if (p1.Status != PromptStatus.OK) return;

            PromptPointOptions ppo = new PromptPointOptions("\nChọn điểm kết thúc: ");
            ppo.BasePoint = p1.Value;
            ppo.UseBasePoint = true;
            PromptPointResult p2 = ed.GetPoint(ppo);
            if (p2.Status != PromptStatus.OK) return;

            using (Transaction tr = db.TransactionManager.StartTransaction())
            {
                BlockTable bt = (BlockTable)tr.GetObject(db.BlockTableId, OpenMode.ForRead);
                BlockTableRecord btr = (BlockTableRecord)tr.GetObject(bt[BlockTableRecord.ModelSpace], OpenMode.ForWrite);

                Line line = new Line(p1.Value, p2.Value);
                btr.AppendEntity(line);
                tr.AddNewlyCreatedDBObject(line, true);

                tr.Commit();
            }

            ed.WriteMessage("\nĐã vẽ đoạn thẳng từ {0} đến {1}", p1.Value, p2.Value);
        }
    }
}
