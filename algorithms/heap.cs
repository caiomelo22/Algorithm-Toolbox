namespace algorithms {
    class MinHeap {
        public int[] heapArray {get;set;}
        public int capacity {get;set;}
        public int currentHeapSize {get;set;}

        public MinHeap(int n) {
            capacity = n;
            heapArray = new int[capacity];
            currentHeapSize = 0;
        }

        public static void Swap(ref int a, ref int b) {
            int buffer = a;
            a = b;
            b = buffer;
        }

        public int Parent (int key) {
            return (key - 1) / 2;
        }

        public int Left (int key) {
            return key * 2 + 1;
        }

        public int Right (int key) {
            return 2 * key + 2;
        }

        public bool InsertKey(int key) 
        {
            if(currentHeapSize == capacity) {
                return false; // Heap full
            }

            int i = currentHeapSize;
            heapArray[i] = key;
            currentHeapSize ++;

            while(i != 0 && heapArray[i] < heapArray[Parent(i)]) {
                Swap(ref heapArray[i], ref heapArray[Parent(i)]);
                i = Parent(i);
            }

            return true;
        }

        public void decreaseKey (int key, int newVal) {
            heapArray[key] = newVal;

            while (key != 0 && heapArray[key] < heapArray[Parent(key)]) {
                Swap(ref heapArray[key], ref heapArray[Parent(key)]);
                key = Parent(key);
            }
        }

        public int getMin() {
            return heapArray[0];
        }

        public int extractMin() {
            if(currentHeapSize <= 0) {
                return int.MaxValue;
            }

            if(currentHeapSize == 1) {
                currentHeapSize --;
                return heapArray[0];
            }

            int root = heapArray[0];

            heapArray[0] = heapArray[currentHeapSize - 1];
            currentHeapSize --;
            MinHeapify(0);

            return root;
        }

        public void deleteKey(int key) {
            decreaseKey(key, int.MinValue);
            extractMin();
        }

        public void MinHeapify(int key) {
            int l = Left(key);
            int r = Right(key);

            int smallest = key;
            if(l < currentHeapSize && heapArray[l] < heapArray[smallest]) {
                smallest = l;
            }
            if(r < currentHeapSize && heapArray[r] < heapArray[smallest]) {
                smallest = r;
            }

            if(smallest != key) {
                Swap(ref heapArray[key], ref heapArray[smallest]);
                MinHeapify(smallest);
            }
        }

        public void increaseKey(int key, int newVal) {
            heapArray[key] = newVal;
            MinHeapify(key);
        }

        public void changeValueOnKey(int key, int newVal) {
            if(heapArray[key] == newVal) {
                return;
            }
            else if(heapArray[key] < newVal) {
                decreaseKey(key, newVal);
            } 
            else if(heapArray[key] > newVal) {
                increaseKey(key, newVal);
            }
        }
    }
}