class Bai1 {

    public static int tinhTongSoLon50(List<int> numbers){
        int sum = 0;
        foreach (int i in numbers){
            if ( i >= 50){
                sum += i;

            }
        }
            return sum;
    }
}
    
