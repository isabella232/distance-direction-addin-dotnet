﻿
/******************************************************************************* 
  * Copyright 2016 Esri 
  *  
  *  Licensed under the Apache License, Version 2.0 (the "License"); 
  *  you may not use this file except in compliance with the License. 
  *  You may obtain a copy of the License at 
  *  
  *  http://www.apache.org/licenses/LICENSE-2.0 
  *   
  *   Unless required by applicable law or agreed to in writing, software 
  *   distributed under the License is distributed on an "AS IS" BASIS, 
  *   WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied. 
  *   See the License for the specific language governing permissions and 
  *   limitations under the License. 
  ******************************************************************************/

namespace ArcMapAddinDistanceAndDirection.ViewModels
{
    class SelectSaveAsFormatViewModel : BaseViewModel
    {

        private bool featureShapeIsChecked = true;
        public bool FeatureShapeIsChecked
        {
            get
            {
                return featureShapeIsChecked;
            }

            set
            {
                featureShapeIsChecked = value;
                RaisePropertyChanged(() => FeatureShapeIsChecked);
            }
        }

        private bool kmlIsChecked = false;
        public bool KmlIsChecked
        {
            get
            {
                return kmlIsChecked;
            }

            set
            {
                kmlIsChecked = value;
                RaisePropertyChanged(() => KmlIsChecked);
            }
        }
    }  
}