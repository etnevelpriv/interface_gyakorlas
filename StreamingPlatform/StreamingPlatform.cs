using System;

namespace StreamingPlatform;

public class StreamingPlatform
{
    public List<IContent> TartalomLista { get; private set; }

    public StreamingPlatform()
    {
        this.TartalomLista = new List<IContent>();
    }
    public void AddContent(IContent content)
    {
        this.TartalomLista.Add(content);
    }

    public IContent GetLeghosszabbTatalom()
    {
        if (this.TartalomLista.Count != 0)
        {
            IContent longestContent = this.TartalomLista[0];
            foreach (IContent content in this.TartalomLista)
            {
                if (content.GetLength() > longestContent.GetLength())
                {
                    longestContent = content;
                }
            }
            return longestContent;
        } else
        {
            throw new Exception("A lista ures");
        }
    }
}
