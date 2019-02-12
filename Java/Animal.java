package New;

public class Animal {

    String name;
    String mx;
    void voice()
    {
        System.out.println(mx);
    }

    void voice(int kol)
    {
        System.out.println("Animal say "+kol+"times "+mx);
        for(int i=0;i<kol;i++){
        System.out.println(mx);
    }
    }

}
