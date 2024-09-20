namespace GradeManager
{
    public class Student
    {
        private string FirstName;
        private string LastName;
        private string StudyProgramme;
        private int NumberOfModules;
        private List<Module> Modules;

        // Constructor for the Student class
        public Student(string firstName, string lastName, string studyProgramme, int numberOfModules)
        {
            Modules = new List<Module>();

            FirstName = firstName;
            LastName = lastName;
            StudyProgramme = studyProgramme;
            NumberOfModules = numberOfModules;
        }

        // Method for a student to add a new module
        public void AddModule(string code, string name, double grade)
        {
            // Create a new module object and add it to the list of modules
            Module module = new Module(code, name, grade);
            Modules.Add(module);
        }

        // Method for a student to update a modules grade
        public void UpdateGrade(string moduleCode, double newGrade)
        {

            // Loop through the list of modules and find the module with the matching code
            // If the module code matches the code entered by the user, update the grade
            foreach (Module codeOfModule in Modules)
            {
                if (codeOfModule.GetModuleCode().Equals(moduleCode))
                {
                    codeOfModule.SetGrade(newGrade);
                }
            }
        }

        // Outputs the students information and the modules they are studying
        public override string ToString()
        {
            string moduleInfo = "";

            // Loops through the list of modules and adds each module to the moduleInfo string
            foreach (Module module in Modules)
            {
                moduleInfo += module.ToString();
            }

            return $"\n Name: {FirstName} {LastName}\nStudy Programme: {StudyProgramme}\n Number of Modules: {NumberOfModules}";
        }
    }
}