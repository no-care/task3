namespace OAiP_laba
{
    class List
    {

        private Figure figure;

        private List next;
        private List previous;

        int count;

        public List(Figure _figure)
        {

            figure = _figure;
            next = null;
            previous = null;
            count = 0;

        }

        public List(Figure _figure, List _previous) {

            figure = _figure;
            next = null;
            previous = _previous;
            count = _previous.getCount() + 1;

        }

        public void add(Figure figure) { if (next == null) next = new List(figure, this); else next.add(figure); }
        public void delete(int num) { 
        
            if(num == 0)
            {

                if (!(next == null && previous == null))
                {
                    if (next == null) { previous.next = null; }
                    else
                    {
                        if (previous == null) { next.previous = null; next.changeCount(); }
                        else
                        {
                            next.previous = previous;
                            previous.next = next;
                            next.changeCount();
                        }
                    }
                }
            }

            if (next != null) next.delete(num - 1);

        }

        public int getCount() { return count; }
        private void changeCount()
        {

            count--;

            if (next != null) next.changeCount();

        }

        public Figure getFigure(int num) {

            if (num == 0) return figure;
            if (next == null) return null;
            return next.getFigure(num --);
        
        }
        public Figure getFigure() { return figure; }

        public List getNext() { return next; }
        public List getPrevious() { return previous; }
        public List at(int num)
        {

            if (num == 0) return this;
            if (next == null && num != 0) return null;
            return next.at(num - 1);

        }
        public List getLast()
        {

            if (next == null) return this;
            return next.getLast();

        }

        public List getNext(Figure figure, List list)
        {

            if (list.figure is figure) return list;
            return getNext(figure, next);
            
        }

    }
}
