public class MinStack {

    private int[] _elems;
    private int[] _min;
    private int _count;
    private int _size;


    public MinStack(int size = 16) {
        _elems = new int[size];
        _min = new int[size];
        _count = 0;
        _size = size;
    }
    
    public void Push(int val) {
        if(_count + 1 > _size) {
            _size *= 2;
            Array.Resize(ref _elems, _size);
            Array.Resize(ref _min, _size);
        }
        _elems[_count] = val;
        if (_count == 0) {
            _min[_count] = val;
        } else {
            _min[_count] = Math.Min(val, _min[_count-1]); 
        }
        _count++;
    }
    
    public void Pop() {
        _count--;
    }
    
    public int Top() {
        return _elems[_count-1];
    }
    
    public int GetMin() {
        return _min[_count-1];
    }
}
