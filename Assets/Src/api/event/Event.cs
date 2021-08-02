public interface Event
{
    public bool IsCancelled();

    public void SetCancelled(bool cancelled);
}
