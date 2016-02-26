namespace DfBAdminToolkit.Common.DataExchange {

    using System;

    public class DataUpdatedEventArgs
          : EventArgs {
        private object[] _data;

        public object Data {
            get { return _data[0]; }
        }

        public object[] DataPack {
            get { return _data; }
        }

        public DataUpdatedEventArgs(object data) {
            _data = new object[] { data };
        }

        public DataUpdatedEventArgs(object[] data) {
            _data = data;
        }
    }
}