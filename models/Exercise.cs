using System.Reflection;

namespace Models
{
    public partial class Exercise
    {
        public int Id { get; set;}
        public string Name{ get; set;} = string.Empty;
        public string? Description { get; set;}
        public string? Instructions { get; set;}
        public Exercise()
        {

        }
    }
}