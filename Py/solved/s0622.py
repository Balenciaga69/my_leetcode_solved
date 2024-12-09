class MyCircularQueue:

    def __init__(self, k: int):
        self._size = k
        self._queue: list[int | None] = [None]*k
        self._front = 0
        self._rear = 0

    def enQueue(self, value: int) -> bool:
        if self.isFull():
            return False
        self._queue[self._rear] = value
        self._rear = (self._rear+1) % self._size
        return True

    def deQueue(self) -> bool:
        if self.isEmpty():
            return False
        self._queue[self._front] = None
        self._front = (self._front+1) % self._size
        return True

    def Front(self) -> int | None:
        if self.isEmpty():
            return -1
        return self._queue[self._rear]

    def Rear(self) -> int | None:
        if self.isEmpty():
            return -1
        return self._queue[self._front]

    def isEmpty(self) -> bool:
        return self._rear == self._front

    def isFull(self) -> bool:
        return self._front == 0 and self._rear == self._size-1

        # Your MyCircularQueue object will be instantiated and called as such:
        # obj = MyCircularQueue(k)
        # param_1 = obj.enQueue(value)
        # param_2 = obj.deQueue()
        # param_3 = obj.Front()
        # param_4 = obj.Rear()
        # param_5 = obj.isEmpty()
        # param_6 = obj.isFull()


mmm = MyCircularQueue(3)
my_bool = mmm.isEmpty()
mmm.enQueue(1)
mmm.enQueue(2)
mmm.enQueue(3)
mmm.enQueue(4)
mmm.deQueue()
mmm.enQueue(5)
my_bool = mmm.isFull()
my_f = mmm.Front()
