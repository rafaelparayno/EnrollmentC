namespace CST.Data
{
    class DataClass
    {

        private static string[] grade_level =
        {
            "Nursery", "Junior Kinder","Senior Kinder","Grade 1","Grade 2","Grade 3","Grade 4","Grade 5","Grade 6","Grade 7","Grade 8","Grade 9", "Grade 10",
        };


        public static string[] preSchool()
        {
            string[] preSchoolArgs = { grade_level[0], grade_level[1], grade_level[2] };
            return preSchoolArgs;
        }

        public static string[] primarySchool()
        {
            string[] primarySchoolArgs = { grade_level[3] , grade_level[4] , grade_level[5] ,
                                            grade_level[6],grade_level[7],grade_level[8]};
            return primarySchoolArgs;
        } 

        public static string[] secondarySchool()
        {
            string[] secondarySchoolArgs =  { grade_level[9] , grade_level[10] , grade_level[11] ,
                                            grade_level[12]};
            return secondarySchoolArgs;
        }

        public static string[] getAllGrade()
        {
            string[] gradeAll = grade_level;
            return gradeAll;
        }
    }
}
