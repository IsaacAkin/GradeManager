namespace GradeManager
{
    public class Module
    {
        private string ModuleCode;
        private string ModuleName;
        private double Grade;

        // Constructor for the Module class
        public Module(string moduleCode, string moduleName, double grade)
        {
            ModuleCode = moduleCode;
            ModuleName = moduleName;
            Grade = grade;
        }


        // ToString override to print out the students module information in an appropriate format
        public override string ToString()
        {
            return $"Module Code: {ModuleCode}\nModule Name: {ModuleName}\nGrade: {Grade}";
        }


        // Getters and Setters for the Module class
        public string GetModuleCode()
        {
            return ModuleCode;
        }

        public void SetModuleCode(string code)
        {
            ModuleCode = code;
        }

        public string GetModuleName()
        {
            return ModuleName;
        }

        public void SetModuleName(string name)
        {
            ModuleName = name;
        }

        public double GetGrade()
        {
            return Grade;
        }

        public void SetGrade(double grade)
        {
            Grade = grade;
        }
    }
}