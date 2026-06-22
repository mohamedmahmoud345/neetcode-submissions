public class TimeMap {
 private readonly Dictionary<string, List<Tuple<int, string>>> _dic;
    public TimeMap()
    {
        _dic = new Dictionary<string, List<Tuple<int, string>>>();
    }

    public void Set(string key, string value, int timestamp)
    {
        if (!_dic.ContainsKey(key))
            _dic[key] = new List<Tuple<int, string>>();

        _dic[key].Add(Tuple.Create(timestamp, value));
    }

    public string Get(string key, int timestamp)
    {
        if (!_dic.ContainsKey(key))
            return "";

        var values = _dic[key];

        int left = 0;
        int right = values.Count - 1;
        var result = "";
        while (left <= right)
        {
            int mid = left + (right - left) / 2;

            if (values[mid].Item1 <= timestamp)
            {
                result = values[mid].Item2;

                left = mid + 1;
            }

            else
                right = mid - 1;
        }
        return result;
    }
}
