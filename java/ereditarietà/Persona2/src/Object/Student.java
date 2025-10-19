package Object;

public class Student extends Person {
    private String schoolClass;


    public Student(String sex, String surname, String name, int age ,String schoolClass) {
        super(sex, surname, name, age);
        this.schoolClass = schoolClass;
    }

    public String getSchoolClass() {
        return schoolClass;
    }

    @Override
    public String toString() {
        return "Student{" +
                "schoolClass='" + schoolClass + '\'' +
                ", name='" + name + '\'' +
                ", surname='" + surname + '\'' +
                ", sex='" + sex + '\'' +
                '}';
    }
}
