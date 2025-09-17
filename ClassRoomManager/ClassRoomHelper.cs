
namespace ClassRoomManager
{
    public static class ClassRoomHelper
    {
        
        
        //Case 1
        public static void AddStudent(List<Student> students) 
        {
            Console.Write("Enter Student name: ");
            string name = Console.ReadLine();

            Console.WriteLine("Enter startlevel: ");
            int level = int.Parse(Console.ReadLine());

            Student studentToAdd = new Student
            {
                Name = name,
                ProgramingLevel = level,
                IsPresent = false,
                Tools = new List<Tool>()

            };

            students.Add(studentToAdd);
            Console.WriteLine($"Student {name} was added to the list");




        }

        //Case 2

        public static void MarkAttendence(List<Student> students)
        { 
            if (students.Count == 0)
            {
                Console.WriteLine("No students in the list. Press any key to continue!");
                Console.ReadKey();
                return;
            }

            Console.WriteLine("Is this student present? Yes/No");

            for (int i = 0; i < students.Count; i++)
            {
                Console.WriteLine($"{i + 1}. {students[i].Name}");
                string response = Console.ReadLine();
                students[i].IsPresent = (response == "yes" || response == "Yes" || response == "YES");

            
            }

            Console.WriteLine("Attendence updated");
            Console.ReadKey();



        } 

        //Case 3

        public static void RunLesson(List<Student> students, Tool[] toolList)
        {
            if (students.Count == 0)
            {

                Console.WriteLine("No students were found. Press any key to continue!");
                Console.ReadKey();
                return;

            }

            Console.WriteLine("Choose today's topic");
            for (int i = 0; i < toolList.Length; i++) 
            {
                Tool t = toolList[i];
                Console.WriteLine($"[{i + 1}]. {t.Name} {t.Difficulty} - {t.Description}");
            
            }

            Console.WriteLine("Choose: ");
            int choice = int.Parse(Console.ReadLine());

            Tool chosenTool = toolList[choice - 1];
            int level = 5;
            int presentCount = 0;

            foreach (Student s in students)
            {

                if (s.IsPresent)
                {
                    presentCount++;

                    s.ProgramingLevel += level;

                    s.LearnTool(chosenTool);

                }


            }

            if (presentCount > 0)
            {
                Console.WriteLine($"Lecture is finished in {chosenTool.Name}, {presentCount} taught. All attended students have been updated!");
            }
            else 
            {
                Console.WriteLine("No students attended!");
            
            }

            Console.WriteLine("Press any key to continue!");
            Console.ReadKey();




        }




        //Case 4
        public static void PrintRoster(List<Student> students)
        {
            if (students.Count == 0)
            { 
                Console.WriteLine("No students in the list");
                return;

            }


            Console.WriteLine("=== CLASSLIST ===");
            
            for (int i = 0; i < students.Count; i++) 
            {
                Console.WriteLine($"{i + 1}. {students[i].Name} | Level: {students[i].ProgramingLevel}/100 | Present: {students[i].IsPresent}");

            }
            
            Console.WriteLine("Press any key to continue");
            Console.ReadKey();

        }


        //case 6

        public static void ResetAttendence(List<Student> students)
        {
            foreach(Student student in students)
            {
                student.IsPresent = false;
            }

            Console.WriteLine("Attendence list has been reset. Press any key to continue!");
            Console.ReadKey();
        }




    }
}
