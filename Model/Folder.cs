using System.Collections.Generic;

namespace Wpf_HW_2.Model
{
    public class Folder : INode
    {
        public string Name { get; set; }
        public List<INode> Nodes { get; set; }
    }
}
