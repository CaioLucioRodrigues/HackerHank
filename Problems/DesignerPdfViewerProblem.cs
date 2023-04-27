using System.Collections.Generic;

namespace HackerHank.Console.Problems
{
    public static class DesignerPdfViewerProblem
    {
        public static int DesignerPdfViewer(List<int> h, string word)
        {
            var length = word.Length;
            var maxLengthLetter = 0;            

            for (int i = 0; i < length; i++)
            {
                var index = (char)word[i] - 'a';
                if (h[index] > maxLengthLetter)
                    maxLengthLetter = h[index];
            }

            return (maxLengthLetter * length);
        }
    }
}
