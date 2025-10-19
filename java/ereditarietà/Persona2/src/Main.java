import java.util.Locale;
import java.util.Scanner;
import Object.*;

public class Main {
    public static void main(String[] args) {

        Scanner sc = new Scanner(System.in);
        Person[] people = null;
        Person person = null;
        int choise = 0, number, follower, age;
        String name, surname, sex, job, schoolClass, team, role, platform;

        do{
            System.out.println("""
                        1. Inserire Persone
                        2. Stampare Persone
                        3. Visualizzare numero follower di un determinato influencer
                        4. Visualizzare nome squadra, del calciatore in input
                        5. Visualizzare lo studente più giovane
                        6. Esci
                        =============================================================
                        inserisci scelta:
                    """);
            choise = sc.nextInt();

            switch(choise){
                case 1:
                    System.out.println("Quante persone vuoi inserire? ");
                    int n = sc.nextInt();
                    sc.nextLine();

                    people = new Person[n];

                    for (int i = 0; i < n; i++) {
                        System.out.println("Nome: ");
                        name = sc.nextLine();
                        System.out.println("Cognome: ");
                        surname = sc.nextLine();
                        System.out.println("sesso: ");
                        sex = sc.nextLine();
                        System.out.println("Anni: ");
                        age = sc.nextInt();
                        sc.nextLine();

                        System.out.println("Lavoro: ");
                        job = sc.nextLine().toLowerCase(Locale.ROOT);

                        switch(job){
                            case "studente":
                                System.out.println("Corso: ");
                                schoolClass = sc.nextLine();

                                people[i] = new Student(sex, surname, name, age, schoolClass);
                                break;
                            case "calciatore":
                                System.out.println("Squadra: ");
                                team = sc.nextLine();
                                System.out.println("Ruolo: ");
                                role = sc.nextLine();
                                System.out.println("Maglia: ");
                                number = sc.nextInt();
                                sc.nextLine();

                                people[i] = new Soccer(sex, surname, name, age, team, role, number);
                                break;
                            case "influencer":
                                System.out.println("Follower: ");
                                follower = sc.nextInt();
                                sc.nextLine();
                                System.out.println("Piattaforma: ");
                                platform = sc.nextLine();

                                people[i] = new Influencer(sex, surname, name, age, follower, platform);
                                break;
                            default:
                                System.out.println("inserire uno tra i seguenti lavori: studente, calciatore, influencer");
                        }
                    }
                    break;
                case 2:
                    if (people == null){
                        System.out.println("Eseguire prima campo 1");
                        break;
                    }

                    for (Person p : people) {
                        System.out.println(p);
                    }

                    break;
                case 3:
                    if (people == null){
                        System.out.println("Eseguire prima campo 1");
                        break;
                    }

                    System.out.println("Inserire nome influencer");
                    name = sc.nextLine();


                    for (Person value : people) {
                        if (value.getName().equals(name)) {
                            person = value;
                            break;
                        }else{
                            System.out.println("la persona "+ name + " non è censita");
                            break;
                        }
                    }

                    if ( !(person instanceof Influencer)) {
                        System.out.println("la persona " + person.getName() + " non è un influencer");
                        break;
                    }

                    System.out.println("l'influencer "+person.getName() + "ha " + ((Influencer) person).getFollower());
                    break;
                case 4:
                    if (people == null){
                        System.out.println("Eseguire prima campo 1");
                        break;
                    }

                    System.out.println("Inserire nome calciatore");
                    name = sc.nextLine();


                    for (Person value : people) {
                        if (value.getName().equals(name)) {
                            person = value;
                            break;
                        }else{
                            System.out.println("la persona "+ name + " non è censita");
                            break;
                        }
                    }

                    if ( !(person instanceof Soccer)) {
                        System.out.println("la persona " + person.getName() + " non è un calciatore");
                        break;
                    }

                    System.out.println("il calciatore "+person.getName() + "è della squadra " + ((Soccer) person).getTeam());
                    break;
                case 5:
                    if (people == null){
                        System.out.println("Eseguire prima campo 1");
                        break;
                    }
                    age = -1;
                    person = null;

                    for(Person p: people){
                        if(p instanceof Student){
                            if (age < p.getAge()){
                                age = p.getAge();
                                person = p;
                            }
                        }
                    }
                    
                    if(person != null){
                        System.out.println(person);
                    }
                    break;
                default:

                    break;
            }

            System.out.println("premere un tasto per continuare");
            sc.nextLine();
        }while(choise!= 6);
    }
}