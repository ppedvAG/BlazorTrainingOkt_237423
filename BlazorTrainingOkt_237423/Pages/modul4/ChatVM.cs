namespace BlazorTrainingOkt_237423.Pages.modul4
{
    public class ChatVM
    {
        public Action OnAdd;
        public List<Nachricht> ChatListe { get; set; } = new List<Nachricht>();
        public void Add(string msg)
        {
            ChatListe.Add(new Nachricht() { Text = msg });
            OnAdd?.Invoke();

        }
    }
}
