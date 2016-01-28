namespace DfBAdminToolkit.Presenter
{
    using DfBAdminToolkit.Model;
    using DfBAdminToolkit.View;
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Reflection;
    using System.Threading;

    public class PresenterBase
    {
        private static readonly object _syncLock = new object();
        protected IModel _model;
        protected IView _view;

        public bool IsViewEventsWired { get; set; }

        public SynchronizationContext SyncContext { get; set; }

        public PresenterBase(IModel model, IView view)
        {
            _model = model;
            _view = view;
            SyncContext = _view.SyncContext;
            Initialize();
            WireViewEvents();
        }

        ~PresenterBase()
        {
            UnWireViewEvents();
            CleanUp();
        }

        protected virtual void Initialize()
        {
        }

        protected virtual void WireViewEvents()
        {
        }

        protected virtual void UnWireViewEvents()
        {
        }

        protected virtual void CleanUp()
        {
        }

        #region Helper

        protected static void SyncProperties<T, E>(
            T source,
            ref E target,
            Type customAttribute,
            Type customAttributeToCompare)
        {
            lock (_syncLock)
            {
                try
                {
                    List<PropertyInfo> sourceProperties = source.GetType().GetProperties()
                        .Where(p => p.GetCustomAttributes(customAttribute, true).Length > 0).ToList();

                    // check whether this has defined comparison attribute.
                    List<PropertyInfo> propertiesToCompare = source.GetType().GetProperties()
                        .Where(p => p.GetCustomAttributes(customAttributeToCompare, true).Length > 0).ToList();

                    bool isSyncAllowed = true;
                    foreach (PropertyInfo srcCompProp in propertiesToCompare)
                    {
                        if (srcCompProp.CanRead)
                        {
                            PropertyInfo tgtCompProp = target.GetType().GetProperty(srcCompProp.Name);
                            if (tgtCompProp != null &&
                                tgtCompProp.PropertyType.Equals(srcCompProp.PropertyType))
                            {
                                object sourceValue
                                    = Convert.ChangeType(
                                        srcCompProp.GetValue(source, null),
                                        srcCompProp.PropertyType
                                    );

                                object targetValue
                                    = Convert.ChangeType(
                                        tgtCompProp.GetValue(target, null),
                                        tgtCompProp.PropertyType
                                    );
                                if (!sourceValue.ToString().Equals(targetValue.ToString()))
                                {
                                    isSyncAllowed = false;
                                }
                            }
                        }
                    }

                    if (isSyncAllowed)
                    {
                        foreach (PropertyInfo srcProp in sourceProperties)
                        {
                            if (srcProp.CanRead)
                            {
                                PropertyInfo tgtProp = target.GetType().GetProperty(srcProp.Name);
                                if (tgtProp != null &&
                                    tgtProp.PropertyType.Equals(srcProp.PropertyType))
                                {
                                    object valueToAssign
                                        = Convert.ChangeType(
                                            srcProp.GetValue(source, null),
                                            tgtProp.PropertyType
                                        );
                                    if (valueToAssign != null)
                                    {
                                        tgtProp.SetValue(target, valueToAssign, null);
                                    }
                                }
                            }
                        }
                    }
                }
                catch
                {
                    throw;
                }
            }
        }

        protected static void SetModelPropertiesFromView<T, E>(ref T model, E view)
        {
            lock (_syncLock)
            {
                try
                {
                    foreach (PropertyInfo viewProperty in view.GetType().GetProperties())
                    {
                        if (viewProperty.CanRead)
                        {
                            PropertyInfo modelProperty
                                = model.GetType().GetProperty(viewProperty.Name);

                            if (modelProperty != null &&
                                modelProperty.PropertyType.Equals(viewProperty.PropertyType))
                            {
                                object valueToAssign
                                    = Convert.ChangeType(
                                        viewProperty.GetValue(view, null),
                                        modelProperty.PropertyType
                                    );

                                if (valueToAssign != null)
                                {
                                    modelProperty.SetValue(model, valueToAssign, null);
                                }
                            }
                        }
                    }
                }
                catch
                {
                    throw;
                }
            }
        }

        protected static void SetViewPropertiesFromModel<T, E>(ref T view, E model)
        {
            lock (_syncLock)
            {
                try
                {
                    foreach (PropertyInfo viewProperty in view.GetType().GetProperties())
                    {
                        if (viewProperty.CanWrite)
                        {
                            PropertyInfo modelProperty
                                = model.GetType().GetProperty(viewProperty.Name);
                            if (modelProperty != null &&
                                modelProperty.PropertyType.Equals(viewProperty.PropertyType))
                            {
                                object modelValue
                                    = modelProperty.GetValue(model, null);

                                if (modelValue != null)
                                {
                                    object valueToAssign
                                        = Convert.ChangeType(
                                            modelValue,
                                            viewProperty.PropertyType
                                        );
                                    if (valueToAssign != null)
                                    {
                                        viewProperty.SetValue(view, valueToAssign, null);
                                    }
                                }
                            }
                        }
                    }
                }
                catch
                {
                    throw;
                }
            }
        }

        #endregion Helper
    }
}