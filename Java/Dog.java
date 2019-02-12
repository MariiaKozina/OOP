package New;
    public class Dog extends Animal{
        private int age;
        Dog ()
        {
            mx="Gav";
        }
        public int getAge () {
            return this.age;
        }
        public void setAge (int num) {
            if (num>0) {
            this.age = num;}
            else {
                System.out.println("Wrong Age!!");
            }
        }

}
