﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Ce code a été généré par un outil.
//     Version du runtime :4.0.30319.42000
//
//     Les modifications apportées à ce fichier peuvent provoquer un comportement incorrect et seront perdues si
//     le code est régénéré.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Sudoku.CNN {
    using System;
    
    
    /// <summary>
    ///   Une classe de ressource fortement typée destinée, entre autres, à la consultation des chaînes localisées.
    /// </summary>
    // Cette classe a été générée automatiquement par la classe StronglyTypedResourceBuilder
    // à l'aide d'un outil, tel que ResGen ou Visual Studio.
    // Pour ajouter ou supprimer un membre, modifiez votre fichier .ResX, puis réexécutez ResGen
    // avec l'option /str ou régénérez votre projet VS.
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Resources.Tools.StronglyTypedResourceBuilder", "17.0.0.0")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    internal class Resources {
        
        private static global::System.Resources.ResourceManager resourceMan;
        
        private static global::System.Globalization.CultureInfo resourceCulture;
        
        [global::System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")]
        internal Resources() {
        }
        
        /// <summary>
        ///   Retourne l'instance ResourceManager mise en cache utilisée par cette classe.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        internal static global::System.Resources.ResourceManager ResourceManager {
            get {
                if (object.ReferenceEquals(resourceMan, null)) {
                    global::System.Resources.ResourceManager temp = new global::System.Resources.ResourceManager("Sudoku.CNN.Resources", typeof(Resources).Assembly);
                    resourceMan = temp;
                }
                return resourceMan;
            }
        }
        
        /// <summary>
        ///   Remplace la propriété CurrentUICulture du thread actuel pour toutes
        ///   les recherches de ressources à l'aide de cette classe de ressource fortement typée.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        internal static global::System.Globalization.CultureInfo Culture {
            get {
                return resourceCulture;
            }
            set {
                resourceCulture = value;
            }
        }
        
        /// <summary>
        ///   Recherche une chaîne localisée semblable à import numpy as np
        ///import pandas as pd
        ///from sklearn.model_selection import train_test_split
        ///from keras.utils import to_categorical
        ///
        ///def get_data_one_shot_fill(file):
        ///
        ///    data = pd.read_csv(file)#.sample(n=10000)
        ///    #print(data.head)
        ///
        ///    feat_raw = data[&apos;quizzes&apos;]
        ///    label_raw = data[&apos;solutions&apos;]
        ///
        ///    feat = []
        ///    label = []
        ///
        ///    for i in feat_raw:
        ///
        ///        x = np.array([int(j) for j in i]).reshape((9,9,1))
        ///        feat.append(x)
        ///
        ///    feat = np.array(feat)
        ///    feat = feat/9
        ///    fe [rest of string was truncated]&quot;;.
        ///    feat -= .5
        ///
        ///    for i in label_raw:
        ///
        ///        x = np.array([int(j) for j in i]).reshape((81,1 [le reste de la chaîne a été tronqué]&quot;;.
        /// </summary>
        internal static string data_processes {
            get {
                return ResourceManager.GetString("data_processes", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to # may require update keras
        ///#!pip install keras --upgrade
        ///import os
        ///
        ///import numpy as np
        ///from keras import models, utils
        ///import pandas as pd
        ///from huggingface_hub import hf_hub_download
        ///from tensorflow import keras
        ///import tensorflow as tf
        ///from tensorflow.python.keras import layers
        ///from tensorflow.python.keras.models import Sequential
        ///
        ///class SudokuSolver:
        ///    def __init__(self, model_path):
        ///        self.model = self.load_model(model_path)
        ///
        ///    def load_model(self, model_path):
        ///        return m [rest of string was truncated]&quot;;.
        /// </summary>
        internal static string FNN {
            get {
                return ResourceManager.GetString("FNN", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to from keras import Input, Model, Sequential
        ///from keras.layers import Add, Conv2D, MaxPooling2D, Concatenate, Activation, Dropout, Flatten, Dense, Reshape, BatchNormalization
        ///from keras.regularizers import l2
        ///

        ///
        ///def get_model():
        ///
        ///    model = keras.models.Sequential()
        ///
        ///    model.add(Conv2D(64, kernel_size=(3,3), activation=&apos;relu&apos;, padding=&apos;same&apos;, input_shape=(9,9,1)))
        ///    model.add(BatchNormalization())
        ///    model.add(Conv2D(64, kernel_size=(3,3), activation=&apos;relu&apos;, padding=&apos;same&apos;))
        ///    model.add(BatchNormalization())
        ///    model.add(Conv2D(128, kernel_size=(1,1), activation=&apos;relu&apos;, [le reste de la chaîne a été tronqué]&quot;;.
        /// </summary>
        internal static string model {
            get {
                return ResourceManager.GetString("model", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Recherche une chaîne localisée semblable à import copy
        ///import keras
        ///import numpy as np
        ///
        ///def norm(a):
        ///    return (a/9)-.5
        ///
        ///
        ///
        ///def denorm(a):
        ///    return (a+.5)*9
        ///
        ///
        ///def inference_sudoku(model, sample):
        ///
        ///    &apos;&apos;&apos;
        ///        This function solve the sudoku by filling blank positions one by one.
        ///    &apos;&apos;&apos;
        ///
        ///    feat = copy.copy(sample)
        ///
        ///    while(1):
        ///
        /// </summary>
        internal static string Sudoku_py {
            get {
                return ResourceManager.GetString("Sudoku.py", resourceCulture);
            }
        }
    }
}
