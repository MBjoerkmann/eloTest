
namespace Models
{
    public partial class ExerciseSet
    {
        public Exercise Exercise { get; set;}
        public int Reps{ get; set;} 
        public float Weight { get; set;}
        public float Distance { get; set;} = 0;
        public float RestTime { get; set;} = 0;
        public ExerciseSet(Exercise exercise)
        {
            Exercise = exercise;
        }
    }
}