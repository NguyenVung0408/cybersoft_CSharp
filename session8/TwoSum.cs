using System.Runtime.Serialization.Formatters;

class TwoSum {
    public static List<int> twoSum(List<int> lst, int target){
        for(int i=0; i<lst.Count - 1; i++){

            for(int j = i+1; j<lst.Count; j++){

                if(lst[i] + lst[j] == target){
                    return new List<int> {i, j};
                }
            }
        }
        return null;
    }


    public static List<int> twoSumDictionary(List<int> lst, int target){
        // Khai báo Dictionary để đánh dấu từng số trong danh sách lst 

        Dictionary<int, int> seenNumbers = new Dictionary<int, int>();
        for (int i = 0; i < lst.Count; i++){
            int completion = target - lst[i];
            if (seenNumbers.ContainsKey(lst[i])){
                return new List<int> {seenNumbers[completion], i};
            } else {
                seenNumbers.Add(lst[i], i);
            }
        }
    }
}