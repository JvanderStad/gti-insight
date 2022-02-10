using GTIinsight.Shared;
using System;
using System.Linq;

namespace GTIinsight.Pages
{
    public partial class Backlog
    {
        private Sector[] _allSectors;

        private int _selectedPeriod;
        private int SelectedPeriod
		{
			get => _selectedPeriod;
			set
			{
				_selectedPeriod = value;
				Calculate();
			}
		}


		private Sector? _selectedSector;
        private Sector? SelectedSector
		{
			get => _selectedSector;
			set
			{
				_selectedSector = value;
				Calculate();
			}
		}


		private int _backlogAll;
		private int _backlogSector;

		private void Calculate()
		{
			_backlogAll = 0;
			_backlogSector = 0;

			if (_selectedPeriod == 0)
				return;

			foreach (var period in DataCollection.Periods.Where(x => x.Value <= _selectedPeriod))
			{
				foreach (var metric in DataCollection.GetMetrics(period))
				{
					_backlogAll += metric.Pending;

					if (metric.Sector == _selectedSector)
						_backlogSector += metric.Pending;
				}
			}
		}

        protected override void OnInitialized()
        {
            _allSectors = Enum.GetValues<Sector>();
        }
    }
}