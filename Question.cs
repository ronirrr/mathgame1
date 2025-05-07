namespace MathGame.Pages
{
    public class Question
    {
        public string QuestionText { get; set; }
        public int Answer { get; set; }
    }

    public static class MathQuestionGenerator
    {
        private static readonly Random random = new Random();

        public static Question GenerateQuestion(int level) // Use Question now
        {
            return level switch
            {
                1 => GenerateAdditionQuestion(1, 10),
                2 => GenerateSubtractionQuestion(5, 15),
                _ => GenerateAdditionQuestion(1, 10) // Default case
            };
        }

        private static Question GenerateAdditionQuestion(int min, int max) // Use Question now
        {
            int num1 = random.Next(min, max + 1);
            int num2 = random.Next(min, max + 1);
            return new Question  // Use Question now
            {
                QuestionText = $"{num1} + {num2} = ?",
                Answer = num1 + num2
            };
        }

        private static Question GenerateSubtractionQuestion(int min, int max) // Use Question now
        {
            int num1 = random.Next(min, max + 1);
            int num2 = random.Next(1, num1 + 1);
            return new Question   // Use Question now
            {
                QuestionText = $"{num1} - {num2} = ?",
                Answer = num1 - num2
            };
        }
    }
}

