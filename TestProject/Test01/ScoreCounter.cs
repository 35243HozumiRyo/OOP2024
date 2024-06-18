using System.Collections.Generic;
using System.IO;

namespace Test01 {
    class ScoreCounter {
        private IEnumerable<Student> _score;

        // コンストラクタ
        public ScoreCounter(string filePath) {
            _score = ReadScore(filePath);
        }


        //メソッドの概要： 
        private static IEnumerable<Student> ReadScore(string filePath) {
            List<Student> students = new List<Student>();
            string[] lines = File.ReadAllLines(filePath);
            foreach (string line in lines) {
                string[] item = line.Split(',');
                Student student = new Student {
                    Name = item[0],
                    Sbject = item[1],
                    Score = int.Parse(item[2])
                };
                students.Add(student);
            }
            return students;
        }
        //メソッドの概要： 
        public IDictionary<string, int> GetPerStudentScore() {
            var dict = new Dictionary<string, int>();
            foreach (var student in _score) {
                if (dict.ContainsKey(student.Sbject)) {
                    dict[student.Sbject] += student.Score;
                } else {
                    dict[student.Sbject] = student.Score;
                }
            }
            return dict;
        }
    }
}
