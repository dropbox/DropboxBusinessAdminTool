namespace DfBAdminToolkit.Common.Utils {

    using System;
    using System.Collections.Generic;

    public class SimpleResolver {
        public static readonly SimpleResolver Instance = new SimpleResolver();
        private readonly Dictionary<Type, Type> _container;
        private readonly Dictionary<Type, object> _singleton;
        private static readonly object _lock = new object();

        private SimpleResolver() {
            _container = new Dictionary<Type, Type>();
            _singleton = new Dictionary<Type, object>();
        }

        public void Bind<ContractType>(Type implementer) {
            lock (_lock) {
                _container.Add(typeof(ContractType), implementer);
            }
        }

        public ContractType Get<ContractType>(params object[] args) {
            lock (_lock) {
                if (!_singleton.ContainsKey(typeof(ContractType))) {
                    ContractType obj = (ContractType)Activator.CreateInstance(_container[typeof(ContractType)], args);
                    _singleton.Add(typeof(ContractType), obj);
                }
                return (ContractType)_singleton[typeof(ContractType)];
            }
        }

        public void Dispose() {
            lock (_lock) {
                _singleton.Clear();
                _container.Clear();
            }
        }
    }
}