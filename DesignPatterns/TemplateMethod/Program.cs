namespace TemplateMethod
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ScoringAlgorithm algorithm;
            algorithm = new MenScoringAlgorithm();
            Console.WriteLine("Score for men : {0}", algorithm.GenerateScore(10, new TimeSpan(0, 2, 34)));

            algorithm = new WomenScoringAlgorithm();
            Console.WriteLine("Score for women : {0}", algorithm.GenerateScore(10, new TimeSpan(0, 2, 34)));

            algorithm = new ChildrenScoringAlgorithm();
            Console.WriteLine("Score for children : {0}", algorithm.GenerateScore(10, new TimeSpan(0, 2, 34)));

            Console.ReadLine();
        }
    }

    public abstract class ScoringAlgorithm
    {
        public int GenerateScore(int hits,TimeSpan time)
        {
            int score = CalculateBaseScore(hits);
            int reduction = CalculateReduction(time);

            return CalculateOverallScore(score,reduction);
        }

        public abstract int CalculateOverallScore(int score, int reduction);
        public abstract int CalculateReduction(TimeSpan time);
        public abstract int CalculateBaseScore(int hits);
    }

    public class MenScoringAlgorithm : ScoringAlgorithm
    {
        public override int CalculateBaseScore(int hits)
        {
            return hits * 100;
        }
        public override int CalculateReduction(TimeSpan time)
        {
            return (int)time.TotalSeconds / 5;
        }

        public override int CalculateOverallScore(int score, int reduction)
        {
            return score - reduction;
        }

    }

    public class WomenScoringAlgorithm : ScoringAlgorithm
    {
        public override int CalculateBaseScore(int hits)
        {
            return hits * 100;
        }

        public override int CalculateReduction(TimeSpan time)
        {
            return (int)time.TotalSeconds / 3;
        }

        public override int CalculateOverallScore(int score, int reduction)
        {
            return score - reduction;
        }
    }

    public class ChildrenScoringAlgorithm : ScoringAlgorithm
    {
        public override int CalculateBaseScore(int hits)
        {
            return hits * 80;
        }
        public override int CalculateReduction(TimeSpan time)
        {
            return (int)time.TotalSeconds / 2;
        }

        public override int CalculateOverallScore(int score, int reduction)
        {
            return score - reduction;
        }

    }
}