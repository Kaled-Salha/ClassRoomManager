namespace ClassRoomManager
{
   
    internal class Program
    {
        static void Main(string[] args)
        {
            
            //List of tools that should be thaught during the course
            Tool[] toolCatalog = new Tool[]
            {
                new Tool { Name = "C#", Description = "Basic programing", Difficulty =5},
                new Tool { Name = "Git", Description = "Source control", Difficulty = 5 },
                new Tool { Name = "SQL", Description = "Relation database", Difficulty = 5},
                new Tool { Name = "Debugging", Description = "Solve problems", Difficulty = 5 },
                new Tool { Name = "Javascript", Description = "Poop", Difficulty = 5}
            };

            //List of students, empty for now
            List<Student> students = new List<Student> 
            {
                new Student { Name = "Alina" , IsPresent = false, ProgramingLevel = 0, Tools = new List<Tool>() },
                new Student { Name = "Artin", IsPresent = false, ProgramingLevel = 0, Tools = new List<Tool>() },
                new Student { Name = "Sebastian", IsPresent = false, ProgramingLevel = 0, Tools = new List<Tool>() },
                new Student { Name = "Avdja", IsPresent = false, ProgramingLevel = 0, Tools = new List<Tool>() },
                new Student { Name = "Linda", IsPresent = false, ProgramingLevel = 0, Tools = new List<Tool>() }


            };

            bool running = true;
            while (running) 
            {
                
                Console.Clear();


                Console.WriteLine("=== KLASSRUMSIMULATORN ===");
                Console.WriteLine("[1] Lägg till student");
                Console.WriteLine("[2] Take attendence");
                Console.WriteLine("[3] Run lecture (Choose tool)");
                Console.WriteLine("[4] Show student list");
                Console.WriteLine("[5] Show individual student details");
                Console.WriteLine("[6] Reset attendence list");
                Console.WriteLine("[7] Exit program");
                Console.WriteLine("Option:");
                int choice = int.Parse(Console.ReadLine());

                switch (choice)
                {
                    case 1:
                        ClassRoomHelper.AddStudent(students);
                        break;

                    case 2:
                        ClassRoomHelper.MarkAttendence(students);
                        break;
                    case 3:
                        ClassRoomHelper.RunLesson(students, toolCatalog);
                        break;
                    case 4:
                        ClassRoomHelper.PrintRoster(students);
                        break;
                    case 5:
                        Console.WriteLine("Show individual student details");
                        break;
                    case 6:
                        ClassRoomHelper.ResetAttendence(students);
                        break;
                    case 7:
                        Console.WriteLine("Exiting program");
                        running = false;
                        break;

                    default:
                        Console.WriteLine("");
                        break;

                
                }






            }



        }
    }
}
