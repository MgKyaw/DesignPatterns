using System.Text;

namespace Memento;

class Editor
{
    private string mContent;
    private EditorMemento mEditorMemento;

    public Editor()
    {
        mContent = "";
        this.mEditorMemento = new EditorMemento(string.Empty);
    }

    public void Type(string words)
    {
        mContent = $"{mContent} {words}";
    }

    public void Save()
    {
        mEditorMemento = new EditorMemento(mContent);
    }

    public void Restore()
    {
        mContent = mEditorMemento.GetContent();
    }

    public string Content()
    {
        return mContent;
    }
}