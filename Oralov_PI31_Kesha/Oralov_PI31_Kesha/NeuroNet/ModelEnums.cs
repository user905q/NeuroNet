namespace Oralov_PI31_Kesha.NeuroNet
{
    enum MemoryMode // режимы работы памяти
    { 
        GET, // считывание памяти 
        SET, // сохранение памяти
        INIT // инициализаация памяти
    }

    enum NeuronType
    { 
        Hidden, // скрытый
        Output // выходной
    }

    enum NetworkMode // режимы работы нейросети
    { 
        Train, // обучение
        Test, // проверка
        Demo // распознование
    }
}
