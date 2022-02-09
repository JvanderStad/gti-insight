using ChartJs.Blazor;
using ChartJs.Blazor.BarChart;
using ChartJs.Blazor.BarChart.Axes;
using ChartJs.Blazor.Common;
using ChartJs.Blazor.Common.Axes;
using ChartJs.Blazor.Common.Enums;
using ChartJs.Blazor.Util;
using GTIinsight.Shared;
using Microsoft.AspNetCore.Components;
using System;
using System.Collections.Generic;
using System.Linq;

namespace GTIinsight.Pages
{

    public partial class Index
    {
        private const int InitalCount = 7;
        private BarConfig _config;
        private Chart _chart;
        
        private readonly Sector[] _allSectors;
        private Sector[] _selectedSectors = Array.Empty<Sector>();
        private readonly Dictionary<Sector, bool> _sectorSelection;

        private IEnumerable<DataCollection.Metric> _sectorMetrics;
        private IEnumerable<GTIMetric> _metrics;

        public Index()
        {
            _allSectors = Enum.GetValues<Sector>();
            _selectedSectors = Enum.GetValues<Sector>();
            _sectorSelection = _allSectors.ToDictionary(x => x, x => false);
        }
        protected override void OnInitialized()
        {
            LoadChart();
        }


        private void SetSelection(Sector sector, ChangeEventArgs args)
        {
            _sectorSelection[sector] = (bool)args.Value;
            _selectedSectors = _sectorSelection.Where(x => x.Value).Select(x => x.Key).ToArray();
            if (_selectedSectors.Length == 0)
                _selectedSectors = _allSectors;

            LoadData();
        }



        private void LoadChart()
        {
            _config = new BarConfig
            {
                Options = new BarOptions
                {
                    Responsive = true,
                    Title = new OptionsTitle
                    {
                        Display = true,
                        Text = "GTI Workload"
                    },
                    Tooltips = new Tooltips
                    {
                        Mode = InteractionMode.Index,
                        Intersect = false
                    },
                    Scales = new BarScales
                    {
                        XAxes = new List<CartesianAxis>
                        {
                            new BarCategoryAxis
                            {
                                Stacked = true                                
                            }
                        },
                        YAxes = new List<CartesianAxis>
                        {
                            new BarLinearCartesianAxis
                            {
                                Stacked = true
                            }
                        }
                    }
                }
            };
            _config.Data.Labels.AddRange(DataCollection.GetPeriodLabels());

            LoadData();
        }

        private void LoadData()
        {
            if (_selectedSectors.Length == _allSectors.Length)
            {
                _config.Options.Title.Text = "EOI Workload - All sectors";
            }
            else
            {
                var stringSectors = String.Join(", ", _selectedSectors.Select(x => x.GetDisplayName()));
                _config.Options.Title.Text = $"EOI Workload - {stringSectors}";
            }

            _config.Data.Datasets.Clear();
            
            // double query for now
            _sectorMetrics = DataCollection.GetSectorMetrics(_selectedSectors);
            _metrics = DataCollection.GetMetrics(_selectedSectors);

            var datasetInvited = new BarDataset<int>(_sectorMetrics.Select(x => x.Invited))
            {
                Label = "Invited",
                BackgroundColor = ColorUtil.FromDrawingColor(ChartColors.Green)
            };
            var datasetRejected = new BarDataset<int>(_sectorMetrics.Select(x => x.Rejected))
            {
                Label = "Rejected",
                BackgroundColor = ColorUtil.FromDrawingColor(ChartColors.Red)
            };
            var datasetPending = new BarDataset<int>(_sectorMetrics.Select(x => x.Pending))
            {
                Label = "Pending",
                BackgroundColor = ColorUtil.FromDrawingColor(ChartColors.Grey)
            };

            _config.Data.Datasets.Add(datasetInvited);
            _config.Data.Datasets.Add(datasetRejected);
            _config.Data.Datasets.Add(datasetPending);
        }
    }
}