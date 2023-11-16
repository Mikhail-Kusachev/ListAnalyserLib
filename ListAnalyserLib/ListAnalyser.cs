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

                uint tmpSum = list[i];

                bool isFound = false; // как по break выйти из основного и вложенного циклов?

                while ((i < list.Count - 1) && (!isFound))
                {
                    // не могу от этой проверки избавиться, все время какая то хрень
                    // если пытаюсь проверку случая, когда первый элемент сразу равен sum засунуть внутрь вложенного цикла
                    // цикл либо за границы массива выходит, либо не успевает сравнить последний элемент массива
                    if (tmpSum == sum)
                    {
                        start = i;
                        end = i + 1;
                        break;
                    }
                    int j = i + 1;
                    while ((j < list.Count) && (tmpSum <= sum))
                    {
                        tmpSum += list[j];

                        if (tmpSum == sum)
                        {
                            start = i;
                            end = j + 1;
                            isFound = true;
                            break;
                        }
                        j++;
                    }
                    i++;
                    tmpSum = list[i];
                }
            } catch (Exception ex)
            {
                Console.WriteLine(ex);
            }

        }            
    }
}