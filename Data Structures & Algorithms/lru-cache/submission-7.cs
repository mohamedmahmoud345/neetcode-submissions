public class LRUCache
{
    private int _capacity;
    private Dictionary<int, Node> _cache;
    private Node _left;
    private Node _right;
    public LRUCache(int capacity)
    {
        _capacity = capacity;
        _cache =new Dictionary<int, Node>();
        _left = new Node(0, 0);
        _right = new Node(0, 0);
        _left.Next = _right;
        _right.Prev = _left;
    }

    private void Insert(Node node)
    {
        var prev = _right.Prev;
        prev.Next = node;
        node.Prev = prev;
        node.Next = _right;
        _right.Prev = node;
    }
    private void Delete(Node node)
    {
        var next = node.Next;
        var prev = node.Prev;
        prev.Next = next;
        next.Prev = prev;
    }
    public int Get(int key)
    {
        if (_cache.ContainsKey(key))
        {
            var node = _cache[key];
            Delete(node);
            Insert(node);
            return node.Value;
        }
        return -1;
    }

    public void Put(int key, int value)
    {
        if (_cache.ContainsKey(key))
        {
            var node = _cache[key];
            Delete(node);
        }
        var newNode = new Node(key, value);
        _cache[key] = newNode;
        Insert(newNode);

        if(_cache.Count > _capacity) {
            var lru = _left.Next;
            Delete(lru);
            _cache.Remove(lru.Key);
        }
    }
}
public class Node
{
    public int Key { get; set; }
    public int Value { get; set; }
    public Node Prev { get; set; }
    public Node Next { get; set; }
    public Node(int key, int value)
    {
        Key = key;
        Value = value;
        Prev = null;
        Next = null;
    }
}