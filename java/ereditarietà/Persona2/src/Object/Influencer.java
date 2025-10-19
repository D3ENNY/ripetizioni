package Object;

public class Influencer extends Person{
    private int follower;
    private String platform;

    public Influencer(String sex, String surname, String name, int age, int follower, String platform) {
        super(sex, surname, name, age);
        this.follower = follower;
        this.platform = platform;
    }

    public int getFollower() {
        return follower;
    }

    public String getPlatform() {
        return platform;
    }

    @Override
    public String toString() {
        return "Influencer{" +
                "follower=" + follower +
                ", platform='" + platform + '\'' +
                ", name='" + name + '\'' +
                ", surname='" + surname + '\'' +
                ", sex='" + sex + '\'' +
                '}';
    }
}
