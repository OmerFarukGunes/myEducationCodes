import java.util.Objects;

public class RationalNum {
    private int x;
    private int y;
    public RationalNum(){
        x=0;
        y=1;
    }
    public RationalNum(int x,int y){
        int maxDivider=findDivider(x,y);
        this.x=((y>0) ?1 :-1)*(x/maxDivider);
        this.y=Math.abs(y)/maxDivider;
    }
    private int findDivider(int x, int y){
        int netX=Math.abs(x);
        int netY=Math.abs(y);
        int maxDivide = 0;
        for (int i =1; i<=netX && i<=netY; i++){
            if(x%i == 0 && y %i ==0){
                maxDivide = i;
            }
        }
        return maxDivide;
    }
    //tek tek boyle 4 islemi yapabilirsin ve ilerde bu paket birinin isine yarayabil;ir
    public RationalNum plus(RationalNum addingNumber){
        int newX = (this.x * addingNumber.y) +(this.y* addingNumber.x);
        int newY = this.y * addingNumber.y;

        return new RationalNum(newX,newY);
    }

    @Override
    public boolean equals(Object o) {
        if (this == o) return true;
        if (o == null || getClass() != o.getClass()) return false;
        RationalNum that = (RationalNum) o;
        return x == that.x && y == that.y;
    }

    @Override
    public int hashCode() {
        return Objects.hash(x, y);
    }

    @Override
    public String toString() {
       if(y==1){
           return x+"";

       }
       else{
           return x +"/"+y;
       }
    }
}
