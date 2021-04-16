public void Pulse(INeuralLayer layer)  
{  
    lock (this)  
    {  
        m_output = 0;  
        foreach (KeyValuePair<INeuronSignal, NeuralFactor> item in m_input)  
            m_output += item.Key.Output * item.Value.Weight;  
        m_output += m_bias.Weight * BiasWeight;  
        m_output = Sigmoid(m_output);  
    }  
} 
