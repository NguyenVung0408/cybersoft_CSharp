class Student {
    private string studentId;

    public string StudentId {
        get { return studentId; }
        set { value = studentId;}
    }
    
    private string studentName;

    public string StudentName {
        get { return studentName; }
        set { 
        if (string.IsNullOrEmpty(value) || value.Length == 0) {
            throw new ArgumentException("Tên học sinh không hợp lệ");
        }
        value = studentName;}
    }

    private double mathScore;

    public double MathScore {
        get { return mathScore; }
        set { 
        if (value < 0){
            throw new ArgumentException("Điểm toán không hợp lệ");
        }
        value = mathScore; }
    }

    private double literatureScore;

    public double LiteratureScore {
        get { return literatureScore;}
        set {
            if (value < 0){
                throw new ArgumentException("Điểm văn không hợp lệ");
            }
            literatureScore = value;
        }
    }

    private double englishScore;

    public double EnglishScore {
        get { return englishScore;}
        set {
            if (value < 0){
                throw new ArgumentException("Điểm tiếng anh không hợp lệ");
            }
            englishScore = value;
        }
    }

    public double averageScore() {
        return (mathScore + literatureScore + englishScore) / 3;
    }

    public string academicRanking(){
        double dtb = averageScore();
        if (dtb < 5)
            return "Yếu";
            else if (dtb < 6.5 || dtb >= 5)
            return "Trung Bình";
            else if (dtb < 8 || dtb >= 6.5)
            return "Khá";
            else return "Giỏi";
            

        
        
    }
}
