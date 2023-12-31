import java.util.HashMap;

public class ScalerThread extends Thread{
    public static HashMap<String, String> map = new HashMap<>();
    private String target;

    ScalerThread(Runnable runnable)
    {
        super(runnable);
        target = runnable.getClass().getName();
    }

    @Override
    public void start()
    {
        super.start();
        map.put(target, this.getName());
    }
}
