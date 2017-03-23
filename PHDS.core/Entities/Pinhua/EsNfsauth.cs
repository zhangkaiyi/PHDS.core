using System;
using System.Collections.Generic;

namespace PHDS.core.Entities.Pinhua
{
    public partial class EsNfsauth
    {
        public int AuthId { get; set; }
        public short AuthType { get; set; }
        public int? UserId { get; set; }
        public int? RoleId { get; set; }
        public short DeptScope { get; set; }
        public string DeptIds { get; set; }
        public int FolderId { get; set; }
        public short CreDir { get; set; }
        public short DelDir { get; set; }
        public short RenameDir { get; set; }
        public short CreFile { get; set; }
        public short UpdFile { get; set; }
        public short DeleteFile { get; set; }
        public short DownloadFile { get; set; }
        public short ListSub { get; set; }
    }
}
