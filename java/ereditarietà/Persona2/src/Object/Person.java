package Object;

public class Person {
    protected String name;
    protected  String surname;
    protected String sex;
    protected int age;

    public Person(String sex, String surname, String name, int age) {
        this.sex = sex;
        this.surname = surname;
        this.name = name;
        this.age = age;
    }

    public String getName() {
        return name;
    }

    public String getSurname() {
        return surname;
    }

    public String getSex() {
        return sex;
    }

    public int getAge() {
        return age;
    }

    @Override
    public String toString() {
        return "Person{" +
                "name='" + name + '\'' +
                ", surname='" + surname + '\'' +
                ", sex='" + sex + '\'' +
                '}';
    }
}