using System.Collections.Generic;

namespace BM2.Models.ViewModels
{
    public class PartsGroupModel
    {
        public string GroupName { get; set; }
        public string Comments { get; set; }

        public ICollection<PartModel> Parts { get; set; }
    }
}