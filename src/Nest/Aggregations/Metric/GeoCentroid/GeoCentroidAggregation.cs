﻿using Elasticsearch.Net.Utf8Json;

namespace Nest
{
	[InterfaceDataContract]
	[ReadAs(typeof(GeoCentroidAggregation))]
	public interface IGeoCentroidAggregation : IMetricAggregation { }

	public class GeoCentroidAggregation : MetricAggregationBase, IGeoCentroidAggregation
	{
		internal GeoCentroidAggregation() { }

		public GeoCentroidAggregation(string name, Field field) : base(name, field) { }

		internal override void WrapInContainer(AggregationContainer c) => c.GeoCentroid = this;
	}

	public class GeoCentroidAggregationDescriptor<T>
		: MetricAggregationDescriptorBase<GeoCentroidAggregationDescriptor<T>, IGeoCentroidAggregation, T>
			, IGeoCentroidAggregation
		where T : class { }
}
