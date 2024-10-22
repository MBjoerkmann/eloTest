namespace Models
{
    public partial class ExerciseSetGroup
    {
        public List<ExerciseSet>? WorkoutSets { get; set; }
        string NameExerciseSetGroup { get; set; } = "";
        public ExerciseSetGroup()
        {

        }
        public void AddWorkoutSetSingle(ExerciseSet workoutSet)
        {
            if (workoutSet == null)
            {
                throw new ArgumentNullException("The workout given was empty");   
            }
            WorkoutSets.Add(workoutSet);
        }
        public void AddExerciseSetMultiple(List<ExerciseSet> ExerciseSets)
        {
            if (ExerciseSets == null)
            {
                throw new ArgumentNullException("The Exerciseset was empty");
            }
            foreach (ExerciseSet ExerciseSet in ExerciseSets)
                ExerciseSets.Add(ExerciseSet);
        }

    }
}