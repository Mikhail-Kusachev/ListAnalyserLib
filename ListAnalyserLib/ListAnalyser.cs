namespace ListAnalyserLib
{
    public class ListAnalyser
    {
        public void FindElementsForSum(List<uint> list, ulong sum, out int start, out int end)
        {
            start = 0;
            end = 0;

            try
            {            
                int i = 0;
                uint tmpSum = 0;

                while (i < list.Count - 1)
                {
                    int j = i;
                    while ((j < list.Count) && (tmpSum <= sum))
                    {
                        tmpSum += list[j];
                        if (tmpSum == sum)
                        {
                            start = i;
                            end = j + 1;
                            return;
                        }
                        j++;
                    }
                    i++;
                    tmpSum = 0;
                }
            } catch (Exception ex)
            {
                Console.WriteLine(ex);
            }

        }            
    }
}