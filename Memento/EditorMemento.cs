using System.Text;

namespace Memento;

class EditorMemento
{
    private string mContent;

    public EditorMemento(string content)
    {
        mContent = content;
    }

    public string GetContent()
    {
        return mContent;
    }
}