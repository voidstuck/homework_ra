//непонятно как придумать так, чтобы не пришлось во второй проект копировать этот класс из первого проекта(
namespace HW5_prog2
{
    public record class ItemsForRecord(ItemsForRecord.Types Type, string Name, DateTime LastDateTime)
    {
        public enum Types
        {
            File = 1,
            Directory = 2,
            Unknown = 3
        }
        public Types Type { get; set; } = Type;
        public string Name { get; set; } = Name;
        public DateTime LastDatetime { get; set; } = LastDateTime;

    }
}
