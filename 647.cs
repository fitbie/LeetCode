Solution solution = new();
solution.CountSubstrings("tlthpowwythupxaszmxhqbfbxegiqzdxzesppfjgycyprjyscubntihrfwbeebqgeclzdccxwxezasfzclndmnfjjqoplbxuygtopqtnpatixyydboldybmdoyfwkevwgxmsrdkwjiyoksilsorcbotqitujdaavjbvrjjwtnimpldrnkfuftxnhzfiwzkhslzolbfmdkqhulpjxmbmzqhawiztcbbaggcccttokwkznsctemmdgutldvpybalridbjmupbjijmexzjuvdfntqxuvdoijbbmbpwhbtdbxlhrvbxrfcoyjbrfsowdamohdsoojivwgoopfjwzdjhlzelkdxpsrkfdkjktptahoeanuuuujdybotiitmttzpnbyrxtjetxhydhlvlsmveddtvaobbvdkwxzoyugojhoapbaghgcanazkpauaorgjluszsezbnaqjxtvoxfitnpwsmywlxdimemymuyehyabrpedfkgrwtgyjvzkvahcbekqsofcvseswvtdixaxrjwjinvrruoskqlxcnxrvaqvsnpxdwjpjaupdyfaaxqsnrcrmkmzmtnndniqxglucqwargfzzqwxvaopxwafbzuifptayzoedznsljslpaoytiqnnlxeegbebslvbbsfoqlbokxakkaxdqyttxkdermidtoxjnjwibnlrsuvdkfcvoeagzpsogmcoeihbvyvjcdirnbbpqhdgoirclqapqzsvuesezbhdjoumxwhtwwnxnwyrnyhpaeqzbirnqxsufritrjkgbftmnjwpoakrzokpopwmwjsimwkvblwplsammgwonxrdkfbongodjnvadspxuvcyxlwvwhonvagznjsslbfayoxpqwrizxdhwgskewymhdlurtbekqsmghgzufkmsvrchskdoudtllfflromzwwahigprsrydcsyionczumedayyvldefctkuzafmwsvbifaxzyqywhzpqbeun");


public class Solution {
    public int CountSubstrings(string s) 
    {
        int result = s.Length;
        HashSet<string> cached = new();

        for (int i = 0; i < s.Length - 1; i++)
        {
            for (int j = i + 1; j < s.Length; j++)
            {
                if (IsPalindrome(i, j)) { result++; }
            }
        }

        bool IsPalindrome(int left, int right)
        {
            int l = left;
            int r = right;
            while (l <= r)
            {
                if (cached.Contains(s[l..(r + 1)]))
                {
                    return true;
                }

                if (s[l] != s[r]) { return false; }
                l++;
                r--;
            }

            cached.Add(s[left..(right + 1)]);
            return true;
        }

        return result;
    }
}


/*
public class Solution {
    public int CountSubstrings(string s) 
    {
        int result = s.Length;
        CountPalindromes(0, 1, false);

        void CountPalindromes(int left, int right, bool isPalindrome)
        {
            if (right >= s.Length)
            {
                if (left >= s.Length) { return; }

                CountPalindromes(left + 1, left + 2, false);
                return;
            }

            if (left >= s.Length)
            {
                return;
            }

            if (isPalindrome)
            {
                Console.WriteLine(s.Substring(left, right - left));
                bool equals = s[right] == s[left];
                if (equals) { result++; }
                
                CountPalindromes(left, right + 1, equals);
            }
            else
            {
                isPalindrome = true;
                int l = left;
                int r = right;
                while (l <= r)
                {
                    if (s[l] != s[r]) { isPalindrome = false; break; }
                    l++;
                    r--;
                }
                if (isPalindrome) { result++; }
                CountPalindromes(left, right + 1, isPalindrome);
            }
        }

        return result;
    }
}
*/