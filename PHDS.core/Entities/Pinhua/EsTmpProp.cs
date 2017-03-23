using System;
using System.Collections.Generic;

namespace PHDS.core.Entities.Pinhua
{
    public partial class EsTmpProp
    {
        public string RtId { get; set; }
        public short SelLockedCell { get; set; }
        public short LockFormula { get; set; }
        public short NoPaste { get; set; }
        public short PasteVonly { get; set; }
        public short CheckValid { get; set; }
        public short CheckDataType { get; set; }
        public short SaveFile { get; set; }
        public short PopWinOnSave { get; set; }
        public short PromptNext { get; set; }
        public short PromptPrint { get; set; }
        public short WebFillable { get; set; }
        public short CanDownload { get; set; }
        public short NoSaveNoPrint { get; set; }
        public short QrySaveLocal { get; set; }
        public short TmpKind { get; set; }
        public short StatCycle { get; set; }
        public short CycleType { get; set; }
        public short SetFormat { get; set; }
        public short LocalUnprotect { get; set; }
        public short CloseAfterSave { get; set; }
    }
}
