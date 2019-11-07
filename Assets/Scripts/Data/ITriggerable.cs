namespace Data {
    public interface ITriggerable {
        void Trigger<T>(T param);
    }
}