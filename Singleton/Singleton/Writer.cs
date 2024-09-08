namespace Eager {
    internal class Writer {
        public static Writer PRT_writer { get; set; } = new Writer();

        private Writer() { }

        public static Writer GetInstance => PRT_writer;
    }
}

namespace Lazy {
    internal class Writer {
        public static Writer? PRT_writer { get; set; }

        private Writer() { }

        public static Writer GetInstance() {
            return PRT_writer ??= new Writer();
        }
    }
}

namespace Synchronised {
    internal class Writer {
        public static Writer? PRT_writer { get; set; }
        private static readonly object _lock = new object(); // Lock object

        private Writer() { }

        public static Writer GetInstance() {
            lock (_lock) {
                PRT_writer ??= new Writer();
            }
            return PRT_writer;
        }
    }
}

namespace Double_Locking {
    internal class Writer {
        public static Writer? PRT_writer { get; set; }
        private static readonly object _lock = new object(); // Lock object

        private Writer() { }

        public static Writer GetInstance() {
            if (PRT_writer is null) {
                lock (_lock) {
                    PRT_writer ??= new Writer();
                }
            }
            return PRT_writer;
        }
    }
}