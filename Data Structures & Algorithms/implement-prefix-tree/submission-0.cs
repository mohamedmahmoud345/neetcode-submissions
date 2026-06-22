public class PrefixTree {
    private HashSet<string> _set;
    public PrefixTree()
    {
        _set = new();
    }

    public void Insert(string word)
    {
        if (_set.Contains(word))
            return;

        _set.Add(word);
    }

    public bool Search(string word)
    {
        if (_set.Contains(word))
            return true;

        return false;
    }

    public bool StartsWith(string prefix)
    {
        foreach (var word in _set)
        {
            if (word.StartsWith(prefix))
                return true;
        }
        return false;
    }
}
