package Object;

public class Soccer extends Person {
    private String team;
    private String role;
    private int number;

    public Soccer(String sex, String surname, String name, int age, String team, String role, int number) {
        super(sex, surname, name, age);
        this.team = team;
        this.role = role;
        this.number = number;
    }

    public String getTeam() {
        return team;
    }

    public String getRole() {
        return role;
    }

    @Override
    public String toString() {
        return "Soccer{" +
                "team='" + team + '\'' +
                ", role='" + role + '\'' +
                ", number=" + number +
                ", name='" + name + '\'' +
                ", surname='" + surname + '\'' +
                ", sex='" + sex + '\'' +
                '}';
    }
}