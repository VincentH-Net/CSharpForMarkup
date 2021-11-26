using System;
using IValueConverter = Microsoft.UI.Xaml.Data.IValueConverter;

namespace Microsoft.UI.Markup
{
	public class FuncConverter<TSource, TDest, TParam> : IValueConverter
	{
		readonly Func<TSource, TDest> convert;
		readonly Func<TDest, TSource> convertBack;

		readonly Func<TSource, TParam, TDest> convertWithParam;
		readonly Func<TDest, TParam, TSource> convertBackWithParam;

		readonly Func<TSource, TParam, string, TDest> convertWithParamAndLanguage;
		readonly Func<TDest, TParam, string, TSource> convertBackWithParamAndLanguage;

		public FuncConverter(Func<TSource, TParam, string, TDest> convertWithParamAndLanguage = null, Func<TDest, TParam, string, TSource> convertBackWithParamAndLanguage = null)
		{ this.convertWithParamAndLanguage = convertWithParamAndLanguage; this.convertBackWithParamAndLanguage = convertBackWithParamAndLanguage; }

		public FuncConverter(Func<TSource, TParam, TDest> convertWithParam = null, Func<TDest, TParam, TSource> convertBackWithParam = null)
		{ this.convertWithParam = convertWithParam; this.convertBackWithParam = convertBackWithParam; }

		public FuncConverter(Func<TSource, TDest> convert = null, Func<TDest, TSource> convertBack = null)
		{ this.convert = convert; this.convertBack = convertBack; }

		public object Convert(object value, Type targetType, object parameter, string language)
		{
			if (convert != null)
				return convert.Invoke(
					value != null ? (TSource)value : default(TSource));

			if (convertWithParam != null)
				return convertWithParam.Invoke(
					value != null ? (TSource)value : default(TSource),
					parameter != null ? (TParam)parameter : default(TParam));

			if (convertWithParamAndLanguage != null)
				return convertWithParamAndLanguage.Invoke(
					value != null ? (TSource)value : default(TSource),
					parameter != null ? (TParam)parameter : default(TParam),
					language);

			return default(TDest);
		}

		public object ConvertBack(object value, Type targetType, object parameter, string language)
		{
			if (convertBack != null)
				return convertBack.Invoke(
					value != null ? (TDest)value : default(TDest));

			if (convertBackWithParam != null)
				return convertBackWithParam.Invoke(
					value != null ? (TDest)value : default(TDest),
					parameter != null ? (TParam)parameter : default(TParam));

			if (convertBackWithParamAndLanguage != null)
				return convertBackWithParamAndLanguage.Invoke(
					value != null ? (TDest)value : default(TDest),
					parameter != null ? (TParam)parameter : default(TParam),
					language);

			return default(TSource); // TODO: Allow non-inline FuncConverter to indicate the fallback value of the binding should be used
		}
	}

	public class FuncConverter<TSource, TDest> : FuncConverter<TSource, TDest, object>
	{
		public FuncConverter(Func<TSource, TDest> convert = null, Func<TDest, TSource> convertBack = null)
			: base(convert, convertBack) { }
	}

	public class FuncConverter<TSource> : FuncConverter<TSource, object, object>
	{
		public FuncConverter(Func<TSource, object> convert = null, Func<object, TSource> convertBack = null)
			: base(convert, convertBack) { }
	}

	public class FuncConverter : FuncConverter<object, object, object>
	{
		public FuncConverter(Func<object, object> convert = null, Func<object, object> convertBack = null)
			: base(convert, convertBack) { }
	}

	public class ToStringConverter : FuncConverter<object, string>
	{
		public ToStringConverter(string format = "{0}")
			: base(o => string.Format(format, o)) { } // TODO: decide how to handle culture
	}

	public class NotConverter : FuncConverter<bool, bool>
	{
		static readonly Lazy<NotConverter> instance = new Lazy<NotConverter>(() => new NotConverter());
		public static NotConverter Instance => instance.Value;
		public NotConverter() : base(t => !t, t => !t) { }
	}
}