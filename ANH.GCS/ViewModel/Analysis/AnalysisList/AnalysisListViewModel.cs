using System.Collections.Generic;
using System.Windows.Input;
using static ANH.GCS.DI;

namespace ANH.GCS
{
    /// <summary>
    /// A view model for the overview analysis list
    /// </summary>
    public class AnalysisListViewModel : BaseViewModel
    {
        #region Public Properties

        /// <summary>
        /// The Search text
        /// </summary>
        public string SearchText { get; set; } = "Search";

        /// <summary>
        /// The analysis list items for the list
        /// </summary>
        public List<AnalysisListItemViewModel> Items { get; set; }

        /// <summary>
        /// The analysis data list
        /// </summary>
        public List<AnalysisListCategoryViewModel> AnalysisDatas { get; set; }

        /// <summary>
        /// The analysis execution list
        /// </summary>
        public List<AnalysisListCategoryViewModel> AnalysisExecutions { get; set; }

        /// <summary>
        /// Indicates if the current item of analysis data is expanded or not
        /// </summary>
        public bool IsDataExpanded { get; set; }

        /// <summary>
        /// Indicates if the current item of analysis execution is expanded or not
        /// </summary>
        public bool IsExecutionExpanded { get; set; }

        /// <summary>
        /// The Create of Analysis Action
        /// </summary>
        public IConActionViewModel Create { get; set; }

        /// <summary>
        /// The Import of Analysis Action
        /// </summary>
        public IConActionViewModel Import { get; set; }

        /// <summary>
        /// The Modify of Analysis Action
        /// </summary>
        public IConActionViewModel Modify { get; set; }

        /// <summary>
        /// The Delete of Analysis Action
        /// </summary>
        public IConActionViewModel Delete { get; set; }

        /// <summary>
        /// A list of all children contained inside this item
        /// </summary>
        public AnalysisViewModel AnalysisList { get; set; }

        #endregion

        #region Public Commands

        /// <summary>
        /// Open alalysis data and analysis execution
        /// </summary>
        public ICommand OpenAnalysisListCommand { get; set; }

        /// <summary>
        /// The command for when the header of analysis data
        /// </summary>
        public ICommand AnalysisDataHeaderCommand { get; set; }

        /// <summary>
        /// The command for when the header of analysis excution
        /// </summary>
        public ICommand AnalysisExecutionHeaderCommand { get; set; }

        /// <summary>
        /// Create new analysis data
        /// </summary>
        public ICommand CreateCommand { get; set; }

        #endregion

        #region Default constructor


        public AnalysisListViewModel()
        {
            OpenAnalysisListCommand = new RelayParameterizedCommand(OpenAnalysisList);

            AnalysisDataHeaderCommand = new RelayCommand(DataExpand);

            AnalysisExecutionHeaderCommand = new RelayCommand(ExecutionExpand);

            CreateCommand = new RelayCommand(CreateAnalysisData);
        }

        #endregion


        #region Command Methods

        // Header Arrow icon image change
        public void DataExpand()
        {
            IsDataExpanded ^= true;
        }

        public void ExecutionExpand()
        {
            IsExecutionExpanded ^= true;
        }

        public void OpenAnalysisList(object parameter)
        {
            if (parameter == null)
                return;

            var para = (AnalysisListItemViewModel)parameter;

            // Current Item is selected
            foreach (var item in Items)
            {
                var itm = (AnalysisListItemViewModel)item;
                if (itm.Category == para.Category)
                    itm.IsSelect = true;
                else
                    itm.IsSelect = false;
            }            

            ViewModelApplication.CurrentCategory = para.Category;

            ViewModelApplication.AnalysisWideMenuVisible = true;
            GetAnalysisListData(para.Category);
        }

        /// <summary>
        /// Get Analysis list data
        /// </summary>
        /// <param name="category">Analysis category</param>
        private void GetAnalysisListData(AnalysisCategory category)
        {
            //if (AnalysisDatas != null)
            //    return;

            ViewModelApplication.CurrentCategory = category;

            IsDataExpanded = true;

            IsExecutionExpanded = true;

            if (category == AnalysisCategory.PlainStrengthAnalysis)
            {
                AnalysisDatas = new List<AnalysisListCategoryViewModel>
                {
                    new AnalysisListCategoryViewModel
                    {
                        Name = "Plain Analysis 01",
                        CanExpand = false
                    },
                    new AnalysisListCategoryViewModel
                    {
                        Name = "Plain Analysis 02",
                        CanExpand = false
                    },
                    new AnalysisListCategoryViewModel
                    {
                        Name = "Plain Analysis 03",
                        CanExpand = false
                    },
                };

                AnalysisExecutions = new List<AnalysisListCategoryViewModel>
                {
                    new AnalysisListCategoryViewModel
                    {
                        Name = "Analysis Parameter",
                        CanExpand = false
                    },
                    new AnalysisListCategoryViewModel
                    {
                        Name = "Analysis Result",
                        CanExpand = false
                    },
                };
            }
            else if (category == AnalysisCategory.CompositeRadiusAnalysis)
            {
                AnalysisDatas = new List<AnalysisListCategoryViewModel>
                {
                    new AnalysisListCategoryViewModel
                    {
                        Name = "Radius Analysis 01",
                        CanExpand = false
                    },
                    new AnalysisListCategoryViewModel
                    {
                        Name = "Radius Analysis 02",
                        CanExpand = false
                    },
                    new AnalysisListCategoryViewModel
                    {
                        Name = "Radius Analysis 03",
                        CanExpand = false
                    },
                };

                AnalysisExecutions = new List<AnalysisListCategoryViewModel>
                {
                    new AnalysisListCategoryViewModel
                    {
                        Name = "Analysis Parameter",
                        CanExpand = false
                    },
                    new AnalysisListCategoryViewModel
                    {
                        Name = "Analysis Result",
                        CanExpand = false
                    },
                };
            }
            else if (category == AnalysisCategory.SandwichPanelAnalysis)
            {
                AnalysisDatas = new List<AnalysisListCategoryViewModel>
                {
                    new AnalysisListCategoryViewModel
                    {
                        Name = "Sandwich Analysis 01",
                        CanExpand = false
                    },
                    new AnalysisListCategoryViewModel
                    {
                        Name = "Sandwich Analysis 02",
                        CanExpand = false
                    },
                    new AnalysisListCategoryViewModel
                    {
                        Name = "Sandwich Analysis 03",
                        CanExpand = false
                    },
                };

                AnalysisExecutions = new List<AnalysisListCategoryViewModel>
                {
                    new AnalysisListCategoryViewModel
                    {
                        Name = "Analysis Parameter",
                        CanExpand = false
                    },
                    new AnalysisListCategoryViewModel
                    {
                        Name = "Analysis Result",
                        CanExpand = false
                    },
                };
            }
            else if (category == AnalysisCategory.JointAnalysis)
            {
                AnalysisDatas = new List<AnalysisListCategoryViewModel>
                {
                    new AnalysisListCategoryViewModel
                    {
                        Name = "Joint Analysis 01",
                        CanExpand = false
                    },
                    new AnalysisListCategoryViewModel
                    {
                        Name = "Joint Analysis 02",
                        CanExpand = false
                    },
                    new AnalysisListCategoryViewModel
                    {
                        Name = "Joint Analysis 03",
                        CanExpand = false
                    },
                };

                AnalysisExecutions = new List<AnalysisListCategoryViewModel>
                {
                    new AnalysisListCategoryViewModel
                    {
                        Name = "Analysis Parameter",
                        CanExpand = false
                    },
                    new AnalysisListCategoryViewModel
                    {
                        Name = "Analysis Result",
                        CanExpand = false
                    },
                };
            }
        }

        /// <summary>
        /// Get Analysis list data
        /// </summary>
        /// <param name="category">Analysis category</param>
        private void GetLibraryListData(AnalysisCategory category)
        {
            //if (AnalysisDatas != null)
            //    return;

            //if (category == AnalysisCategory.Materials)
            //{
            //    AnalysisDatas = new List<AnalysisListCategoryViewModel>
            //    {
            //        new AnalysisListCategoryViewModel
            //        {
            //            Name = "Ply material",
            //            AnalysisList = new ObservableCollection<AnalysisListCategoryItemViewModel>
            //            {
            //                new AnalysisListCategoryItemViewModel
            //                {
            //                    Name = "Ply material 01",
            //                    Content = AnalysisContent.Material
            //                },
            //                new AnalysisListCategoryItemViewModel
            //                {
            //                    Name = "Ply material 02",
            //                    Content = AnalysisContent.Material
            //                },
            //                new AnalysisListCategoryItemViewModel
            //                {
            //                    Name = "Ply material 03",
            //                    Content = AnalysisContent.Material
            //                }
            //            },
            //            CanExpand = true
            //        },
            //        new AnalysisListCategoryViewModel
            //        {
            //            Name = "Core material",
            //            AnalysisList = new ObservableCollection<AnalysisListCategoryItemViewModel>
            //            {
            //                new AnalysisListCategoryItemViewModel
            //                {
            //                    Name = "Core material 01",
            //                    Content = AnalysisContent.Material
            //                },
            //                new AnalysisListCategoryItemViewModel
            //                {
            //                    Name = "Core material 02",
            //                    Content = AnalysisContent.Material
            //                },
            //                new AnalysisListCategoryItemViewModel
            //                {
            //                    Name = "Core material 03",
            //                    Content = AnalysisContent.Material
            //                }
            //            },
            //            CanExpand = true
            //        }
            //    };
            //}
            //else if (category == AnalysisCategory.Laminate)
            //{
            //    AnalysisDatas = new List<AnalysisListCategoryViewModel>
            //    {
            //        new AnalysisListCategoryViewModel
            //        {
            //            Name = "Laminate Data",
            //            AnalysisList = new ObservableCollection<AnalysisListCategoryItemViewModel>
            //            {
            //                new AnalysisListCategoryItemViewModel
            //                {
            //                    Name = "Laminate 01",
            //                    Content = AnalysisContent.Laminate
            //                },
            //                new AnalysisListCategoryItemViewModel
            //                {
            //                    Name = "Laminate 02",
            //                    Content = AnalysisContent.Laminate
            //                },
            //                new AnalysisListCategoryItemViewModel
            //                {
            //                    Name = "Laminate 03",
            //                    Content = AnalysisContent.Laminate
            //                }
            //            },
            //            CanExpand = true
            //        },
            //    };
            //}
            //else if (category == AnalysisCategory.Fastener)
            //{
            //    AnalysisDatas = new List<AnalysisListCategoryViewModel>
            //    {
            //        new AnalysisListCategoryViewModel
            //        {
            //            Name = "Fastener Data",
            //            AnalysisList = new ObservableCollection<AnalysisListCategoryItemViewModel>
            //            {
            //                new AnalysisListCategoryItemViewModel
            //                {
            //                    Name = "Fastener 01",
            //                    Content = AnalysisContent.Fastener
            //                },
            //                new AnalysisListCategoryItemViewModel
            //                {
            //                    Name = "Fastener 02",
            //                    Content = AnalysisContent.Fastener
            //                },
            //                new AnalysisListCategoryItemViewModel
            //                {
            //                    Name = "Fastener 03",
            //                    Content = AnalysisContent.Fastener
            //                }
            //            },
            //            CanExpand = true
            //        }
            //    };
            //}
        }

        /// <summary>
        /// Create new analysis data
        /// </summary>
        private void CreateAnalysisData()
        {
            if (AnalysisList == null)
                AnalysisList = new AnalysisViewModel();

            //AnalysisList.TitleName = analysisparameter.Name;
            AnalysisList.AnalysisSubListVisible = true;
            AnalysisList.CurrentContent = AnalysisContent.Unit;
            AnalysisList.CurrentAction = AnalysisAction.Create;
            AnalysisList.Items = new List<AnalysisSubListItemViewModel>
                                {
                                    new AnalysisSubListItemViewModel
                                    {
                                        AnalysisName = "",
                                        Name = "",
                                        Contents = AnalysisContent.Unit,
                                        IsSelected = true
                                    },
                                    new AnalysisSubListItemViewModel
                                    {
                                        AnalysisName = "",
                                        Name = "Geometry",
                                        Contents = AnalysisContent.Geometry,
                                        IsSelected = false
                                    },
                                    new AnalysisSubListItemViewModel
                                    {
                                        AnalysisName = "",
                                        Name = "Loads",
                                        Contents = AnalysisContent.Loads,
                                        IsSelected = false
                                    },
                                    new AnalysisSubListItemViewModel
                                    {
                                        AnalysisName = "",
                                        Name = "Analysis",
                                        Contents = AnalysisContent.parameter,
                                        IsSelected = false
                                    },
                                    new AnalysisSubListItemViewModel
                                    {
                                        AnalysisName = "",
                                        Name = "Result",
                                        Contents = AnalysisContent.Result,
                                        IsSelected = false
                                    },
                                };

            // Get contents List and data
            ViewModelAnalysis.OpenContentsList(AnalysisList);
        }

        #endregion
    }
}
