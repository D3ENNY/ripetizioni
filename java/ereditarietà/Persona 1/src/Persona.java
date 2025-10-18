public class Persona {

    private int age;
    private String name;
    private String surname;

    public Persona(int age, String name, String surname){
        this.age = age;
        this.name = name;
        this.surname = surname;
    }

    public int getAge() {
        return age;
    }
    
    public String getName() {
        return name;
    }

    public String getSurname() {
        return surname;
    }

    public void visualizza(){
        System.out.printf("name -> %s\nsurname -> %s\nage -> %d\n", name, surname, age);
    }

    public String getPeople(){
        return "name -> "+ name +" surname -> "+ surname +" age -> "+ age + " ";
    }


}
